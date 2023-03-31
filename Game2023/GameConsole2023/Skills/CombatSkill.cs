using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole2023.Skills
{
    /*Скіли:
  [0]Варвар:
 1. Кривавий Хрест(BloodyCross)
 2. Залізна хватка(IronGrip)
 3. Петля(Noose)
 4. Удар в спину(Backstab)
  [1]Танк:
 1. Силовий удар(PowerBlow)
 2. Силовий хват(PowerRunning)
 3. Гострий удар(DoubleEdge)
 4.Удар в спину(Backstab)
  [2]Розбійник:
 1.Крадіжка
 2.Швидкі ноги
 3.
 4.Удар в спину(Backstab)
  */
    abstract class CombattSkill : NameTrait
    {
        public CombattSkill()
        {

        }
    }
    abstract class NameTrait
    {
        protected string name = "";

        public void setName(string name) => this.name = name;
        public string getName() => this.name;
    }
}
