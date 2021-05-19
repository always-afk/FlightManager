using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace FlightManager
{
    public static class FormOpener
    {
        private static readonly ICollection<Form> openForms = new List<Form>();

        public static T ShowForm<T>() where T : Form, new()
        {
            var form = openForms.FirstOrDefault(x => x.GetType() == typeof(T));

            if (form is null)
            {
                form = new T();
                form.FormClosed += (s, e) => { openForms.Remove(form); };
                openForms.Add(form);
            }

            form.Show();
            form.WindowState = FormWindowState.Normal;
            form.Activate();

            return form as T;
        }
    }
}
