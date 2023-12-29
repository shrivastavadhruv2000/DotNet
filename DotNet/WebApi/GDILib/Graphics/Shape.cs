namespace Iet.Drawing;
public abstract class Shape{
    public Shape(){
        this.Width=0;
        this.Color="black";
    }
    public Shape(int w,string c){
        this.Width=w;
        this.Color= c;
    }

    public int Width{get;set;}
    public string Color{get;set;}
    public abstract void Draw();
    public override string ToString(){
        return "width="+ this.Width + ", color="+this.Color;
    }
}