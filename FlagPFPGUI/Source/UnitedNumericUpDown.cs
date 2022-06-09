using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FlagPFPGUI.Source
{
	public class UnitedNumericUpDown : NumericUpDown
	{
		private string _UnitText = null;
		private bool _AddSpace = false;

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		[Category("Appearance")]
		[Description("The unit text that is showed after the value.")]
		public string UnitText
		{
			get => _UnitText;
			set
			{
				_UnitText = value;

				UpdateEditText();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		[Category("Appearance")]
		[Description("Tells the control to add a space before the unit text.")]
		public bool AddSpace
		{
			get => _AddSpace;
			set
			{
				_AddSpace = value;

				UpdateEditText();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		[Category("Appearance")]
		[Description("Tells the control to set the caret at the end of the value on focus. If false, it will select the entire content.")]
		public bool SetCaretAtEnd { get; set; }

		protected override void OnEnter(EventArgs e)
		{
			base.OnEnter(e);

			if (SetCaretAtEnd)
			{
				this.Select(this.Text.Length, 0);
			}
			else this.Select(0, this.Text.Length);
		}

		protected override void UpdateEditText()
		{
			if(_UnitText != null && _UnitText != string.Empty)
			{
				string Space = _AddSpace ? " " : string.Empty;

				this.Text = $"{this.Value}{Space}{_UnitText}";
			}
			else base.UpdateEditText();
		}

		protected override void ValidateEditText()
		{
			ParseEditText();
			UpdateEditText();
		}

		protected new void ParseEditText()
		{
			try
			{
				//This will match any number that isnt part of the unit text.
				Regex Regex = new Regex($@"[^{_UnitText} ]+");
				Match Match = Regex.Match(this.Text);

				if(Match.Success)
				{
					string Text = Match.Value;

					if(!string.IsNullOrEmpty(Text) && Text != "-")
					{
						if (this.Hexadecimal)
						{
							this.Value = ClampValue(Convert.ToInt32(Text, 16));
						}
						else this.Value = ClampValue(Decimal.Parse(Text, CultureInfo.CurrentCulture));
					}
				}
			}
			catch { }
			finally
			{
				this.UserEdit = false;
			}
		}

		private decimal ClampValue(decimal Value)
		{
			if(Value < this.Minimum)
			{
				Value = this.Minimum;
			}
			if(Value > this.Maximum)
			{
				Value = this.Maximum;
			}

			return Value;
		}
	}
}
