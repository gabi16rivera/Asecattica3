﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASECATTICA
{
    public partial class AdmEstados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GvEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GvEstados.SelectedRow;
            Response.Redirect("AdmEstadosAct.aspx");
        }
    }
}