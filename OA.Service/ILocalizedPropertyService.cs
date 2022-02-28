using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface ILocalizedPropertyService
    {
        IEnumerable<LocalizedProperty> GetLocalProperties();
        LocalizedProperty GetLocalProperty(int id);
        void InsertLocalProperty(LocalizedProperty localizedProperty);
        void UpdateLocalProperty(LocalizedProperty localizedProperty);
        void DeleteLocalProperty(int id);
    }
}
