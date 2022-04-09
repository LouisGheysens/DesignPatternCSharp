using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePattern.Interfaces;

namespace CompositePattern
{
    //Class wuch includes all the CRUD OPERATIONS
    public class Composite : IComponent, IEnumerable
    {
        private List<IComponent> _children = new List<IComponent>();
        public IEnumerator GetEnumerator()
        {
            foreach (IComponent child in _children)
                yield return child;
        }
        public void AddChild(IComponent child)
        {
            _children.Add(child);
        }
        public void RemoveChild(IComponent child)
        {
            _children.Remove(child);
        }
        public IComponent GetChild(int index)
        {
            return _children[index];
        }
        public void Operation()
        {
            string message = string.Format("Composite with {0} child(ren)", _children.Count);
            Console.WriteLine(message);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
