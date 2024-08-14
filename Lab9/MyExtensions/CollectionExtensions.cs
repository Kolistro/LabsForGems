namespace MyExtensions
{
    public static class CollectionExtensions
    {
        public static TSource First<TSource>(this IEnumerable<TSource> source, Predicate<TSource>? predicate = null)
        {
            if (source == null || source.Count() == 0)
                throw new ArgumentNullException("Коллекция пуста!", nameof(source));

            if (predicate == null)
                return source.ElementAt(0);

            foreach (TSource item in source)
            {
                if (predicate?.Invoke(item) == true)
                    return item;
            }

            throw new InvalidOperationException("Элемент удовлетворяющий условию не найден!");
        }

        public static TSource? FirstOrDefault<TSource>(this IEnumerable<TSource>? source, Predicate<TSource>? predicate = null)
        {
            if (source == null || source.Count() == 0)
                return default(TSource);

            if (predicate == null)
                return source.ElementAt(0);

            foreach (TSource item in source)
            {
                if (predicate?.Invoke(item) == true)
                    return item;
            }

            return default(TSource);
        }

        public static IEnumerable<TSource> Where<TSource> (this IEnumerable<TSource> source, Predicate<TSource> predicate)
        {
            if (source == null || source.Count() == 0)
                throw new ArgumentNullException("Коллекция пуста!", nameof(source));

            List<TSource> subset = new List<TSource>();

            foreach (TSource item in source)
            {
                if (predicate?.Invoke(item) == true)
                    subset.Add(item);
            }

            return subset;
        }

        public static bool Any<TSource>(this IEnumerable<TSource> source, Predicate<TSource> predicate = null)
        {
            if (source == null || source.Count() == 0)
                throw new ArgumentNullException("Коллекция пуста!", nameof(source));

            if (predicate == null)
                return true;

            foreach (TSource item in source)
            {
                if (predicate?.Invoke(item) == true)
                    return true;      
            }

            return false;
        }
    }
}
