using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.Windows
{
    class CheckBoxMediatorPattern
    {
        private CheckBox _warrior;
        private CheckBox _berserker;
        private CheckBox _mage;

        private CheckBox _twoHand;
        private CheckBox _oneHand;
        private CheckBox _wand;

        public CheckBoxMediatorPattern()
        {
        }

        public void AddClass(CheckBox __warrior, CheckBox __berserker, CheckBox __mage)
        {
            _warrior = __warrior;
            _berserker = __berserker;
            _mage = __mage;
        }

        public void AddWeapon(CheckBox __oneHand, CheckBox __twoHand, CheckBox __wand)
        {
            _oneHand = __oneHand;
            _twoHand = __twoHand;
            _wand = __wand;
        }

        public void Check(CheckBox __object)
        {
            __object.Checked = true;
        }

        public void UnCheck(CheckBox __object)
        {
            __object.Checked = false;
        }

        public void ChangeAction(CheckBox __object)
        {
            if (_warrior.Equals(__object))
            {
                UnCheck(_berserker);
                UnCheck(_mage);

                Check(_oneHand);
                UnCheck(_twoHand);
                UnCheck(_wand);
            }
            else if (_berserker.Equals(__object))
            {
                UnCheck(_warrior);
                UnCheck(_mage);

                Check(_oneHand);
                Check(_twoHand);
                UnCheck(_wand);
            }
            else if (_mage.Equals(__object))
            {
                UnCheck(_warrior);
                UnCheck(_berserker);

                UnCheck(_oneHand);
                UnCheck(_twoHand);
                Check(_wand);
            }
        }
    }
}
