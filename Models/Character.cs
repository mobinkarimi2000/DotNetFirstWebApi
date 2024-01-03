namespace DotNetFirstWebApi.Models
{
    public class Character
    {
        public int ID{get;set;}=1;
        public string Name{get;set;}="mobin";
        public int HitPoint{get;set;}=1000;
        public int Strength{get;set;}=10;
        public int Defense{get;set;}=10;
        public int Intelligence{get;set;}=10;
        public RpgEnum RpgEnum { get; set; }=RpgEnum.Knight;
    }
}