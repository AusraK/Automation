using Automation.Page;
using AutomationSolution.Page;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AutomationSolution.Test
{

    public static void TestVartuAutomatika(string width, string height, bool gateAuto, bool darbai, string result)
    {
        
        VartuTechnikaPage page = new VartuTechnikaPage(_driver);
        page.InsertWidthAndHeight(width, height);
        page.CheckAutoCheckBox(gateAuto);
        page.CheckWorksCheckBox(darbai);
        page.ClickCalculateButton();
        page.CheckResult(result);
        page.InsertWidthAndHeight(width, height)
            .CheckAutoCheckBox(gateAuto)
            .CheckWorksCheckBox(darbai)
            .ClickCalculateButton()
            .CheckResult(result);
    }
}


 
    

