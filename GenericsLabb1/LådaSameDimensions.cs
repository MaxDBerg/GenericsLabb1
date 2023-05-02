using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLabb1
{

    public class LådaSameDimensions : EqualityComparer<Låda>
    {
        public LådaSameDimensions() { }
        public override bool Equals(Låda låda1, Låda låda2)
        {
            if (låda1.höjd == låda2.höjd && låda1.längd == låda2.längd && låda1.bredd == låda2.bredd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Låda obj)
        {
            return obj.höjd.GetHashCode() ^ obj.längd.GetHashCode() ^ obj.bredd.GetHashCode();
        }
    }
}