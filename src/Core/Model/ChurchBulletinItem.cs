using ProgrammingWithPalermo.ChurchBuletin.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWithPalermo.ChurchBulletin.Core.Model
{
    public class ChurchBulletinItem : EntityBase<ChurchBulletinItem>
    {
        public override Guid Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
    }
}
