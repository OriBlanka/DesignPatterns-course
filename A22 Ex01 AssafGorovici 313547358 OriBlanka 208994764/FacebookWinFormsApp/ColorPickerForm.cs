using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class ColorPickerForm : Form
    {
        String Hex;
        public ColorPickerForm()
        {
            InitializeComponent();
        }

        private void m_RedTrackBar_Scroll(object sender, EventArgs e)
        {
            m_ColorPanel.BackColor = Color.FromArgb(m_RedTrackBar.Value, m_GreenTrackBar.Value, m_BlueTrackBar.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}", m_RedTrackBar.Value, m_GreenTrackBar.Value, m_BlueTrackBar.Value);
        }

        private void m_GreenTrackBar_Scroll(object sender, EventArgs e)
        {
            m_ColorPanel.BackColor = Color.FromArgb(m_RedTrackBar.Value, m_GreenTrackBar.Value, m_BlueTrackBar.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}", m_RedTrackBar.Value, m_GreenTrackBar.Value, m_BlueTrackBar.Value);
        }

        private void m_BlueTrackBar_Scroll(object sender, EventArgs e)
        {
            m_ColorPanel.BackColor = Color.FromArgb(m_RedTrackBar.Value, m_GreenTrackBar.Value, m_BlueTrackBar.Value);
            Hex = string.Format("{0:X2}{1:X2}{2:X2}", m_RedTrackBar.Value, m_GreenTrackBar.Value, m_BlueTrackBar.Value);
        }

        private void ColorPickerForm_Load(object sender, EventArgs e)
        {
            m_ColorPanel.BackColor = Color.Black;
        }

        /*public event Action ExitClicked;

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
        }*/
    }
}
