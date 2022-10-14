using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyQueue_Curtis
{
    internal class EmergencyRoom
    {
        private PriorityQueue<string, int> _priorityQueue;
 
        public EmergencyRoom()
        {
            _priorityQueue = new PriorityQueue<string, int>();

        }
        public void Add(string name, int priority)
        {
            _priorityQueue.Enqueue(name, priority);
        }
        public string Remove()
        {
            return _priorityQueue.Dequeue();
        }
        public List<string> List()
        {
            List<string> patientList = new List<string>();
            while (_priorityQueue.Count > 0)
            {
                patientList.Add(_priorityQueue.Dequeue().ToString());
            }
            foreach (string patient in patientList)
            {
                _priorityQueue.Enqueue(patient, 0);
            }
            return patientList;
        }        
    }
}
