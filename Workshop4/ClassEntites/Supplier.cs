/********************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 217 Rapid OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a Suppliers class definition and forms part of the CPRG 214
* Threaded Project Workshop 4.
*
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntites
{
    // Suppliers class definition which mirrors the Travel Experts Suppliers table.
    public class Supplier
    {
        public int SupplierId { get; set; }

        public string SupName { get; set; } // string is reference type and thus nullable

        public override string ToString()
        {
            return "Supplier Id: " + SupplierId.ToString() + ",   " + "Supplier Name: " + SupName;
        }

    }

}
