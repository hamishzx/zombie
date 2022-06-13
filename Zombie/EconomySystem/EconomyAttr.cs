#region << File Comment >>

/* ----------------------------------------------------------------
 * Author：Hamish Chengcheng Zou, hamish.zou@stu.hunau.edu.cn
 * Date&Time：11 June 2022, Saturday @00:25 GMT+8
 * ===============================================================
 * All scripts in this field is basically for course experiment use
 * It may direct problems if use outside specific environment
 * **NO** reference value
 * ----------------------------------------------------------------*/

#endregion

namespace Zombie
{
    public enum EconomyType
    {
        gold
    }
    public class EconomyAttr
    {
        private readonly EconomyType _economyType;
        private readonly int _quantity;

        public EconomyAttr(EconomyType economyType, int quantity)
        {
            this._economyType = economyType;
            this._quantity = quantity;
        }

        public EconomyType economyType => _economyType;
        
        public int quantity => _quantity;
    }
}