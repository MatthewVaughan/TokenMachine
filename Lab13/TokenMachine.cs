using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class TokenMachine
    {
        //Declare data stored in object
        private int NumTokens;
        private int NumQuarters;

        /// <summary>
        /// Set Tokens Method
        /// </summary>
        /// <param name="value"></param>
        public void SetTokens(int value)
        {
            //set number of tokens
            NumTokens = value;
        }

        /// <summary>
        /// Set Quarters Method
        /// </summary>
        /// <param name="value"></param>
        public void SetQuarters(int value)
        {
            //set number of quarters
            NumQuarters = value;
        }

        /// <summary>
        /// Get Tokens Method
        /// </summary>
        /// <returns="NumTokens"></returns>
        public int GetNumTokens()
        {
            //Get number of tokens
            return NumTokens;
        }

        /// <summary>
        /// Get Quarters Method
        /// </summary>
        /// <returns="NumQuarters"></returns>
        public int GetNumQuarters()
        {
            //Get number of quarters
            return NumQuarters;
        }

        /// <summary>
        /// Give out a token Method
        /// </summary>
        /// <returns="NumTokens"></returns>
        public int GiveToken()
        {
            //Declare constant
            const int ONE = 1;

            //Take away 1 token from tokens value
            return NumTokens = NumTokens - ONE;
        }

        /// <summary>
        /// Receive Quarter Method
        /// </summary>
        /// <returns="NumQuarters"></returns>
        public int TakeQuarter()
        {
            //Declare constant
            const int ONE = 1;

            //Add 1 quarter to quarters value
            return NumQuarters = NumQuarters + ONE;
        }
    }
}
