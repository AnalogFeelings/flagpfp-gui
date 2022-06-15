using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FlagPFPGUI.Source
{
	public class PictureBoxWithText : PictureBox
	{
		private string _EmptyText = null;
		private Color _ForeColor = SystemColors.Control;

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		[Category("Appearance")]
		[Description("The text that is shown when there is no image set.")]
		public string EmptyText
		{
			get => _EmptyText;
			set
			{
				_EmptyText = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		[Category("Appearance")]
		[Description("The foreground color.")]
		public override Color ForeColor
		{
			get => _ForeColor;
			set
			{
				_ForeColor = value;
			}
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			if (this.Image == null)
			{
				StringFormat Format = new StringFormat()
				{
					Alignment = StringAlignment.Center,
					LineAlignment = StringAlignment.Center
				};

				using (SolidBrush Brush = new SolidBrush(this.ForeColor))
				{
					pe.Graphics.DrawString(_EmptyText, this.Font, Brush, this.ClientRectangle, Format);
				}
			}
			else base.OnPaint(pe);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			this.Invalidate();

			base.OnSizeChanged(e);
		}
	}
}
