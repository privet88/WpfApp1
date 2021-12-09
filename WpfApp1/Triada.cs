using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Triad
    {
        private int[] _triada;
        public Triad()
        {
            _triada = new int[3];
            _triada[0] = 0;
            _triada[1] = 0;
            _triada[2] = 0;
           
        }
        public Triad(int firstnum, int secondnum, int thirdnum)
        {
            _triada[0] = firstnum;
            _triada[1] = secondnum;
            _triada[2] = thirdnum;
            
        }
        public int FirstNumber { get => _triada[0]; set => _triada[0] = value; }
        public int SecondNumber { get => _triada[1]; set => _triada[1] = value; }
        public int ThirdNumber { get => _triada[2]; set => _triada[2] = value; }
        public int[] TriadArray
        {
            get => _triada;
            set
            {
                if (value.Length != 3) throw new Exception("The length of the entered array is not equal to 3", new ArrayTypeMismatchException());
                _triada = value;
            }
        }
        public void SumTriad(int inNum ,out int[] thirdTriada)
        {
            thirdTriada = new int[3];
            for(int i=0; i<3;i++)
            {
               thirdTriada[i]= _triada[i] + inNum;
            }
        }
        public void ProizTriad(int inNum, out int[] thirdTriada)
        {
            thirdTriada = new int[3];
            for (int i = 0; i < 3; i++)
            {
                thirdTriada[i] = _triada[i] * inNum;
            }
        }
    
        public void SumTriads(int firstNumber, int secondNumber, int thirdNumber)
        {
            _triada[0] += firstNumber;
            _triada[1] += secondNumber;
            _triada[2] += thirdNumber;
        }
        public bool Compare(int number)
        {
            foreach (var item in _triada)
            {
                if (item != number) return false;
            }
            return true;
            
               

        }
    }
}
