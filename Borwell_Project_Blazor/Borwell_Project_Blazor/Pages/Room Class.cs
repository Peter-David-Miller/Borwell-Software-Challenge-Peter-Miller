using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borwell_Project_Blazor.Pages
{
   
    public class Room
    {
        public float LengthFloat;
        public float WidthFloat;
        public float HeightFloat;
        public float Area;
        public float LengthSideWalls;
        public float WidthSideWalls;
        public float SurfaceArea;
        public float Volume;


        public void SetLF(float LF) { LengthFloat = LF; }
        public float GetLF() { return LengthFloat; }
        public void SetWF(float WF) { WidthFloat = WF; }
        public float GetWF() { return WidthFloat; }
        public void SetHF(float LF) { HeightFloat = LF; }
        public float GetHF() { return HeightFloat; }
        public void SetArea(float A) { Area= A; }
        public float GetArea() { return Area; }
        public void SetLSW(float LSW) { LengthSideWalls = LSW; }
        public float GetLSW() { return LengthSideWalls; }
        public void SetWSW(float WSW) { WidthSideWalls = WSW; }
        public float GetWSW() { return WidthSideWalls ; }
        public void SetSA(float LF) { SurfaceArea = LF; }
        public float GetSA() { return SurfaceArea; }
        public void SetV(float V) { Volume = V; }
        public float GetV() { return Volume; }

        public Room(float LengthFloat, float WidthFloat, float HeightFloat, float Area, float LengthSideWalls, float WidthSideWalls, float SurfaceArea,float Volume)
        {
            this.SetLF(LengthFloat);
            this.SetWF(WidthFloat);
            this.SetHF(HeightFloat);
            this.SetArea(Area);
            this.SetLSW(LengthSideWalls);
            this.SetWSW(WidthSideWalls);
            this.SetSA(SurfaceArea);
            this.SetV(Volume);
        }
    }
}

