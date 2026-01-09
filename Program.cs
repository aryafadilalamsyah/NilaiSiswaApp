// See https://aka.ms/new-console-template for more information
int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Nama Siswa: ");
nama = Console.ReadLine();

Console.Write("Nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75){
    Console.WriteLine("LULUS woy");
}
else {
    Console.WriteLine("Sory Rak lulus we");
}