using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scipts {
    class Pet {
        private string name { get; set; }
        private string type { get; set; }
        private int hungry { get; set; }
        private int defecation { get; set; }
        private int goWalk { get; set; }
        private int love { get; set; }

        public Pet() {
            hungry = 0;
            defecation = 0;
            goWalk = 0;
            love = 0;
        }
    }
}
