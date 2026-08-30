using System;

namespace Unidad1POO
{
    public class Estudiante
    {
        // Atributos privados (estado) - protegidos con encapsulamiento
        private string nombre;
        private int edad;
        private string matricula;

        // Constructor: se ejecuta al crear un objeto de esta clase
        public Estudiante(string nombre, int edad, string matricula)
        {
            this.nombre = nombre;
            this.Edad = edad; // usamos la propiedad para validar desde el inicio
            this.matricula = matricula;
        }

        // Propiedad con validación (esto ES el encapsulamiento en acción)
        public int Edad
        {
            get { return edad; }
            set
