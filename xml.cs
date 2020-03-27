using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    public class xml
    {
        public static string[] GetRefText(string[] refcodes, XmlElement xmlDoc)
        {
            //XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.Load(@"XmlSampleFiles/ReferenceText.xml");
            //xmlDocument.DocumentElement

            //    //Parsing xml document passed as input parameter
            //    XDocument xdoc = XDocument.Parse(xmlDoc.InnerXml);

            //    //Using linq query to get Reference Text values for given reference codes, if values are found it will return an array with results otherwise empty array it will return.
            //    //In modern techniques linq is more efficient than creating a logic for this search criteria.
            //    return xdoc?.Descendants(AppConstant.ReferenceTag)?.Where(x => refcodes?.Contains(x.Attribute(AppConstant.RefCodeTag)?.Value) == true)?.Descendants(AppConstant.RefTextTag)?.Select(refText => refText.Value)?.ToArray();

            //xpath
            //        <Cell>          
            //    <CellContent>
            //        <Para>                               
            //            <ParaLine>                      
            //                <String>ABCabcABC abcABC abc ABCABCABC.</string> 
            //            </ParaLine>                      
            //        </Para>     
            //    </CellContent>
            //</Cell>

            //        XPathNavigator nav;
            //        XPathDocument docNav;
            //        string xPath;

            //        docNav = new XPathDocument("c:\\books.xml");
            //        nav = docNav.CreateNavigator();
            //xPath = "/Cell/CellContent/Para/ParaLine/String/text()";

            //string value = nav.SelectSingleNode(xPath).Value


            //     [TestClass]
            //public class EdiFactTest
            //{
            //    /// <summary>
            //    /// Method tests empty string 
            //    /// Expected output is zero length array
            //    /// </summary>
            //    [TestMethod]
            //    public void PraseString_EmptyString_ReturnZeroLenghtObject()
            //    {
            //        var result = EdiFact.ParseString("");
            //        Assert.IsTrue(result?.Length == 0);
            //    }

            //    /// <summary>
            //    /// Method tests EdiFact string 
            //    /// Expected output is an array with loc segments
            //    /// </summary>
            //    [TestMethod]
            //    public void PraseString_EditFactString_ReturnLocArray()
            //    {
            //        var result = EdiFact.ParseString(@"UNA: +.? 'UNB+UNOC:3+2021000969+4441963198+180525:1225+3VAL2MJV6EH9IX+KMSV7HMD+CUSDECU-IE++1++1'UNH + EDIFACT + CUSDEC:D: 96B: UN: 145050'BGM+ZEM:::EX+09SEE7JPUV5HC06IC6+Z'LOC + 17 + IT044100'LOC+18+SOL'LOC + 35 + SE'LOC+36+TZ'LOC + 116 + SE003033'DTM+9:20090527:102'DTM + 268:20090626:102'DTM+182:20090527:102'");
            //        Assert.IsTrue(result?.Length > 0);
            //    }
        }


      

    }
}
