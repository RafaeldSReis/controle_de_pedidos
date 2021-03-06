using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_pedidos.WForm
{
    public static class Util
    {

        public static bool HasErrors(this ErrorProvider ep, Control pai)
        {
            bool retorno = false;
            foreach (Control filho in pai.Controls)
            {
                if (filho.Controls.Count > 0)
                    retorno = ep.HasErrors(filho);

                if (!retorno)
                {
                    if (!string.IsNullOrWhiteSpace(ep.GetError(filho)))
                        return true;
                }
                else
                    return retorno;

            }


            return false;
        }
    }
}
