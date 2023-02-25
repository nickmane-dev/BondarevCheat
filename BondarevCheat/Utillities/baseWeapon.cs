using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondarevCheat.Utillities
{
    class baseWeapon
    {
        public int GetWeaponID()
        {
            return Module.Bondarev.Read<int>(Module.Client + Offsets.m_iItemDefinitionIndex);
        }

        public bool IsBomb()
        {
            var id = this.GetWeaponID();
            switch (id)
            {
                case 49:
                    return true;
            }

            return false;
        }

        public bool IsGrenade()
        {
            var id = this.GetWeaponID();
            switch (id)
            {
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                case 48:
                    return true;
            }

            return false;
        }

        public bool IsKnife()
        {
            var id = this.GetWeaponID();
            switch (id)
            {
                case 42:
                case 59:
                case 500:
                case 505:
                case 506:
                case 507:
                case 508:
                case 509:
                case 512:
                case 514:
                case 515:
                case 516:
                    return true;
            }

            return false;
        }

        public bool IsPistol()
        {
            var id = this.GetWeaponID();
            switch (id)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 30:
                case 32:
                case 36:
                case 61:
                    return true;
            }

            return false;
        }

        public bool IsSniper()
        {
            var id = this.GetWeaponID();
            switch (id)
            {
                case 9:
                case 11:
                case 38:
                case 40:
                    return true;
            }

            return false;
        }

        public bool IsRestrictedRcs()
        {
            var id = this.GetWeaponID();
            switch (id)
            {
                case 1:
                case 9:
                case 11:
                case 25:
                case 27:
                case 29:
                case 35:
                case 38:
                case 40:
                    return true;
            }

            return false;
        }
    }
}
