using HR;
Employee e1=new Employee();

WageEmployee wg1= new WageEmployee();

List<Employee> employees=new List<Employee>();
employees.Add(e1);
employees.Add(wg1);




foreach(Employee emp in employees){
    Console.WriteLine(emp);
    //console.WriteLine(emp.)
}
