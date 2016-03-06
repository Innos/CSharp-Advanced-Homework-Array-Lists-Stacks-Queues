define(['Country'],function(){
   var Town = (function(){
       function Town(name,country){
           this.name = name;
           this.country = country;
       }
       return Town;
   })();
    return Town;
});
