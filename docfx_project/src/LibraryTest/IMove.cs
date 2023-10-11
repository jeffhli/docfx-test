using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    public interface IMove
    {
        /// <summary>
        /// Move length
        /// </summary>
        /// <param name="length">length</param>
        void Move(int length);
    }
}
