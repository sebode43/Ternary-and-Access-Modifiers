using System;
using System.Collections.Generic;
using System.Text;

namespace Ternary_and_Access_Modifiers {
    public class Customer {

        public string Name { get; set; }
        public int ID { get; private set; }
        private bool IsNationalAccount { get; set; }
        private static int NextID = 1;

        public void NationalAccount(string YesOrNo) {
            this.IsNationalAccount = YesOrNo.Equals("yes")? true : false;
        }

        public static string PrintNextID() {
            return $"Next ID is {NextID}";
        }

        public Customer(string Name) {
            this.ID = NextID;
            this.Name = Name;
            NextID++;

        }

    }
}
