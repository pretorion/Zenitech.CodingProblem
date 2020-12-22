using System;
using System.Collections;

namespace Zenitech.CodingProblem
{
    public class UInt10
    {
        public UInt10(ushort val)
        {
            var myBitArray = new BitArray(BitConverter.GetBytes(val));
            b0 = myBitArray[0];
            b1 = myBitArray[1];
            b2 = myBitArray[2];
            b3 = myBitArray[3];
            b4 = myBitArray[4];
            b5 = myBitArray[5];
            b6 = myBitArray[6];
            b7 = myBitArray[7];
            b8 = myBitArray[8];
            b9 = myBitArray[9];
        }
        public ushort ToUInt16()
        {
            bool[] bits = new bool[] { b0, b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            BitArray bitArray = new BitArray(bits);
            int[] array = new int[1];
            bitArray.CopyTo(array, 0);
            return (ushort)array[0];
        }
        private bool b0;
        private bool b1;
        private bool b2;
        private bool b3;
        private bool b4;
        private bool b5;
        private bool b6;
        private bool b7;
        private bool b8;
        private bool b9;
    }
}
