﻿using System;

namespace Ex32
{
    class Circle : Surface
    {
        readonly public float radius;
        public Circle(float radius = 0)
        {
            this.radius = radius;
        }
        public override float GetSurface()
        {
            return (float)(radius * radius * Math.PI);//longで計算してからfloatに変換、桁落ちしにくい
        }
        public override float GetCircumference()
        {
            return (float)(radius * 2 * Math.PI);
        }
        public override void GetBounds(out float width, out float height)
        {
            width = this.radius * 2;
            height = this.radius * 2;
        }
    }
}