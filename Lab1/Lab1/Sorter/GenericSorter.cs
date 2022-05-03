using Lab1.Sorter;

namespace Lab1.Service
{
    public class GenericSorter<T> where T : IComparable<T>
    {
        public static T[] BubbleSort(T[] arr, SortDirection sortDirection = SortDirection.ASC)
        {
            T temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            validateSortDirection(arr, sortDirection);

            return arr;
        }

        public static T[] InsertionSort(T[] arr, SortDirection sortDirection = SortDirection.ASC)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            validateSortDirection(arr, sortDirection);

            return arr;
        }

        public static T[] SelectionSort(T[] arr, SortDirection sortDirection = SortDirection.ASC)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j].CompareTo(arr[min_idx]) < 0)
                        min_idx = j;

                T temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }

            validateSortDirection(arr, sortDirection);

            return arr;
        }

        private static void validateSortDirection(T[] arr, SortDirection sortDirection)
        {
            if (sortDirection == SortDirection.DESC)
            {
                Array.Reverse(arr);
            }
        }
    }
}
