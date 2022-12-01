using Project2.Forms.Components;

namespace Project2.Utils
{
    public class Alert
    {
        public static void Show(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
    }
}
