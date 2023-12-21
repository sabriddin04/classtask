class Circle{

  double _radius;
   
   double PI=3.14159;




   public Circle( double radius)
   {
    _radius=radius;
   }
   public Circle()
   {
    
   }

   public void SetRadius(double radius){

      _radius=radius;

   }
    public double GetRadius(){
      
        return _radius;

    }
    public double GetArea()
    {
       return PI*_radius*_radius;
    }
   
    public double GetDiameter() {

      return 2*_radius;

    } 
    public double GetCircumference() {
        return 2*PI*_radius;

    }







}