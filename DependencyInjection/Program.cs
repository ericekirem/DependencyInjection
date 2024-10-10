
using DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Teacher nesnesi oluşturuluyor
        IOgretmen teacher = new Teacher("Ahmet", "Yılmaz");

        // Dependency Injection ile Teacher nesnesi ClassRoom'a veriliyor
        ClassRoom classRoom = new ClassRoom(teacher);

        // Öğretmenin bilgilerini ekrana yazdırıyoruz
        Console.WriteLine(classRoom.GetTeacherInfo());
    }
}


