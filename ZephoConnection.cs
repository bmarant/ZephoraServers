using System;
using UnityEngine;

namespace ZephoFoxer
{
    public class ZephoConnection
    {
        float xy;
        float yz;
        float zy;



        public void PlayerPosition(float x, float y, float z)
        {
            xy = x;
            yz = y;
            zy = z;
        }




    }
}
