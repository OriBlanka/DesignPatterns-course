using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class ColorPickerForm : Form
    {
        private Color m_ChosenRGB;

        public Color ChosenColor => m_ChosenRGB;

        public event Action ExitClicked;

        public ColorPickerForm()
        {
            InitializeComponent();
        }

        private void notify()
        {
            ExitClicked?.Invoke();
        }

        public void Attach(Action i_ObserverToAdd)
        {
            ExitClicked += i_ObserverToAdd;
        }

        public void Detach(Action i_ObserverToRemove)
        {
            ExitClicked -= i_ObserverToRemove;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            notify();
            base.OnClosing(e);
        }

        private void m_RedTrackBar_Scroll(object sender, EventArgs e)
        {
            changePanelColor();
        }

        private void m_GreenTrackBar_Scroll(object sender, EventArgs e)
        {
            changePanelColor();
        }

        private void m_BlueTrackBar_Scroll(object sender, EventArgs e)
        {
            changePanelColor();
        }

        private void ColorPickerForm_Load(object sender, EventArgs e)
        {
            m_ColorPanel.BackColor = SystemColors.Control;
        }

        private void m_SubmitColorButton_Click(object sender, EventArgs e)
        {
            m_ChosenRGB = Color.FromArgb(m_RedTrackBar.Value, m_GreenTrackBar.Value, m_BlueTrackBar.Value);
            Close();
        }

        private void changePanelColor()
        {
            m_ColorPanel.BackColor = Color.FromArgb(m_RedTrackBar.Value, m_GreenTrackBar.Value, m_BlueTrackBar.Value);
        }
    }
}
