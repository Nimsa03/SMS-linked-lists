using SMS_linked_lists;

SinglyLinkedList studentList = new SinglyLinkedList();
bool exit = false;

while (!exit)
{
    Console.WriteLine("STUDENT MANAGEMENT SYSTEM");
    Console.WriteLine("press 1 to Insert new student");
    Console.WriteLine("press 2 to Search student by index Number");
    Console.WriteLine("press 3 to Remove student by index number");
    Console.WriteLine("press 4 to Display all students");
    Console.WriteLine("press 5 to Exit");
    Console.Write("Enter yur choice:");

    if(int.TryParse(Console.ReadLine(),out int choice))
    {
        switch (choice)
        {
            case 1:
                insertStudent(studentList);
                break;
            case 2:
                searchStudent(studentList);
                break;
            case 3:
                deleteStudent(studentList);
                break;
            case 4:
                studentList.DisplayAll();
                break;
            case 5:
                Console.WriteLine("EXIT");
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}


static void insertStudent(SinglyLinkedList list) 
{
    Console.Write("Enter index number:");
    int indexNum = int.Parse(Console.ReadLine());

    Console.Write("Enter name:");
    string name = Console.ReadLine();

    Console.Write("Enter GPA: ");
    double gpa = double.Parse(Console.ReadLine());

    Console.Write("Enter admission year:");
    int year = int.Parse(Console.ReadLine());

    Console.Write("enter NIC: ");
    string nic = Console.ReadLine();

    Student newStudent = new Student(indexNum, name, gpa, year, nic);
    if (list.Insert(newStudent))
    {
        Console.WriteLine("successfully Added");
    }
    else
    {
        Console.WriteLine("Failed");
    }
}
static void deleteStudent(SinglyLinkedList list)
{
    Console.Write("Enter the index number of the studednt you want to remove");
    int indexNum = int.Parse(Console.ReadLine());
    if (list.remove(indexNum))
    {
        Console.WriteLine("Student removed successully");
    }
    else
    {
        Console.WriteLine("student not found");
    }
}
static void searchStudent(SinglyLinkedList list) 
{   Console.WriteLine("Enter the index Number to search");
    int index = int.Parse(Console.ReadLine());
    Student student = list.Search(index);
    if(student != null)
    {
        Console.WriteLine(student.ToString());
    }
    else
    {
        Console.WriteLine("Student not found");
    }

}


