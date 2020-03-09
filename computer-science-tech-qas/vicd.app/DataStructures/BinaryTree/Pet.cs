using System;
using System.Collections.Generic;
using System.Text;

namespace vicd.app.DataStructures.BinaryTree
{
    internal class Pet
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Pet(int id, string name, int age) =>
            (Id, Name, Age) = (id, name, age);
    }
}
