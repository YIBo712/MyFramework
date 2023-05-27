


namespace System.Collections.Generic
{
    public static partial class System_List_Extension
    {
        public static bool TryGetValue<T>(this System.Collections.Generic.List<T> set, int index, out T value)
        {

            value = default(T);
            if (!set.IsNullOrEmpty() && index < set.Count)
            {
                value = set[index];
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool IsNullOrEmpty<T>(this System.Collections.Generic.List<T> dataSet)
        {
            return dataSet == null || dataSet.Count <= 0;
        }
    }


}

