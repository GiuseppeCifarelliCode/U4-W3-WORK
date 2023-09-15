using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class carrello : System.Web.UI.Page
    {
        List<Prodotto> Carrello = new List<Prodotto>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Carrello = (List<Prodotto>)Session["Carrello"];

                if (Carrello != null && Carrello.Count > 0)
                {
                    message.Visible = false;
                    SvuotaCarrello.Visible = true;
                    GridView1.DataSource = Carrello;
                    GridView1.DataBind();
                } else {
                SvuotaCarrello.Visible = false;
                message.Visible = true;
            }
            
        }


        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            Carrello.Clear();
            Response.Redirect("default.aspx");
        }

        protected void Remove_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            int id = Convert.ToInt32(btn.CommandArgument);
                foreach (Prodotto prodotto in Carrello)
                {
                    if (prodotto.Id == id)
                    {
                        int i = Carrello.IndexOf(prodotto);
                        Carrello.Remove(prodotto);
                        Response.Redirect("carrello.aspx");
                        break;
                    }
                }
            
        }

       
    }
}