using BOL;
using BLL;
using Util;

StudentManager smgr = new StudentManager();
List<Student> s_arr = new List<Student>();
s_arr = smgr.getStudents();

// Display.putData(s_arr);
Display.getData();




