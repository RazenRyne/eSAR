using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARDAL;
using eSARBDO;
namespace eSARLogic
{
    public class GradeLevelLogic
    {
        List<GradeLevelBDO> gList = new List<GradeLevelBDO>();
        GradeLevelDAO gdao = new GradeLevelDAO();
        public List<GradeLevelBDO> GetAllGradeLevels()
        {
            return gdao.GetAllGradeLevels();
        }
        public string GetGradeLevel(string gradeLevel)
        {
            gList = GetAllGradeLevels();
            GradeLevelBDO g = new GradeLevelBDO();
            g = gList.Find(p => p.GradeLev == gradeLevel);
            return g.Description;
        }
    }
}
