class Date{


   int day;
   int month;
   int year;
     


     public Date(int first ,int second,int third)
     {
        day=first;
        month=second;
        year=third;
     }
     

    public int  GetDay(){

        return day;
    }
     public int  GetMonth(){

        return month;

     }
      public int  GetYear(){

        return year;
    }
     public string  ToString(){

        return $" DATA: {day}/{month}/{year}";
    }





}