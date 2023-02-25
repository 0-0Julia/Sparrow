using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Birds_Guide
{
    public partial class AdminPage : System.Web.UI.Page{

        DataTable dt;
        public string st = "";

        public string errorMessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["admin"] == null)
              //  Response.Redirect("HomePage.aspx");

            if (Request.Form["delete"] == null && Request.Form["update"] == null)
            {
                SetDataToForm();
            }
            else
            { 
                if (Request.Form["delete"] != null)
                    DeleteAcc();
                else
                    GetDataFromAdmin();
            }
            
        }
        private void SetDataToForm()
        {

            dt = MyAdoHelper.ExecuteUsersTbl();

            int size = dt.Rows.Count;
            if (size > 0)
            {
                st += "<thead><tr>";
                st += "<th> Country: </th>";
                st += "<th> Gender: </th>";
                st += "<th> Username: </th>";
                st += "<th>	Email: </th>";
                st += "<th>	Phone: </th>";
                st += "<th>	Access Key: </th>";
                st += "<th>	Update </th>";
                st += "<th>	Delete </th>";
                st += "</tr></thead>";
            }
            else
                st = "<p>*no users singed up*</p>";
            st += "<tbody>";

            for (int i = 0; i < size; i++)
            {
                st += "<tr style='font-size:14px'>";
                st += "<form id='form1' method='post' runat='server'>";
                st += "<input class='input dis' type='hidden'      id='id'  name='id'  value='" + dt.Rows[i]["Id"] + "'>";
                st += "<td> <input class='input dis' type='text'   value='" + dt.Rows[i]["Country"] + "' disabled/> </td>";
                st += "<td> <input class='input dis' type='text'   value='" + dt.Rows[i]["Gender"] + "' disabled/> </td>";
                st += "<td> <input class='input dis' type='text'   value='" + dt.Rows[i]["Username"] + "' disabled/> </td>";
                st += "<td> <input class='input' type='email'      id='email' name='email' value='" + dt.Rows[i]["Email"] + "' /> </td>";
                st += "<td> <input class='input' type='text'       id='phone' name='phone' value='" + dt.Rows[i]["Phone"] + "' /> </td>";
                st += "<td> <input class='input' type='number'     id='accesskey' name='accesskey' value='" + dt.Rows[i]["AccessKey"] + "' /> </td>";

                st += "<td> <input class='btn upd'   type='submit' name='update' id='update' value='Update' /></td>";
                st += "<td> <input class='btn del'   type='submit' name='delete' id='delete' value='Delete' /></td>";

                st += "</form></tr>";
            }
            st += "</tbody>";
        }
        protected void DeleteAcc()
        {
            MyAdoHelper.Delete(Request.Form["username"]);
            SetDataToForm(); 
        }
    
        private void GetDataFromAdmin()
        {
            MyAdoHelper.UpdateAdmin(int.Parse(Request.Form["id"]), Request.Form["email"], Request.Form["phone"], int.Parse(Request.Form["accesskey"]));
            SetDataToForm();
        }
    }
}
