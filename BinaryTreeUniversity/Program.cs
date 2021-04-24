using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector Financiero";
            vicFinPosition.Salary = 750;

           Position contadorPosition = new Position();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe financiero";
            jefeFinPosition.Salary = 610;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaría Financiera 1 ";
            secFin1Position.Salary = 350;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaría Financiera 2 ";
            secFin2Position.Salary = 350;

            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vicerector académico";
            vicAcadPosition.Salary = 780;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe de Registro";
            jefeRegPosition.Salary = 640;

            Position sectReg2 = new Position();
            sectReg2.Name = "Secretario de registro 2";
            sectReg2.Salary = 360;

            Position sectReg1 = new Position();
            sectReg1.Name = "Secretario de registro 1";
            sectReg1.Salary = 400;

            Position asist2 = new Position();
            asist2.Name = "Asistente 2";
            asist2.Salary = 170;

            Position asist1 = new Position();
            asist1.Name = "Asistente 1";
            asist1.Salary = 250;

            Position mensajero = new Position();
            mensajero.Name = "mensajero";
            mensajero.Salary = 90;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);      
            universityTree.CreatePosition(universityTree.Root, sectReg2, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, sectReg1, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2, sectReg1.Name);
            universityTree.CreatePosition(universityTree.Root, asist1, sectReg1.Name);
            universityTree.CreatePosition(universityTree.Root, mensajero, asist2.Name);

          
            universityTree.PrintTree(universityTree.Root);
            Console.WriteLine("Total salaries " + universityTree.addSalaries(universityTree.Root));
            Console.ReadLine();

        }

        

    }
}
