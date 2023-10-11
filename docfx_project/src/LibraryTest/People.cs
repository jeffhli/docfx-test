using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    /// <summary>
    /// Represent a people object
    /// </summary>
    public class People : IMove
    {
        /// <summary>
        /// Age of the people
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Name of the people
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public People()
        { 
        
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="length"><inheritdoc/></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Move(int length)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine($"Move {length}");
        }
    }
}
