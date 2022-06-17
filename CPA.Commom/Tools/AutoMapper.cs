namespace CPA.Commom.Tools {
    public static class AutoMapper {

        public static T Map<T>(Object from, T to) {

            var fieldsFrom = from.GetType().GetProperties().ToList();

            var fieldsTo = to.GetType().GetProperties().ToList();

            foreach (var field in fieldsTo) {

                var fieldFrom = fieldsFrom.Where(x => x.Name.Equals(field.Name)).FirstOrDefault();

                if(fieldFrom != null)
                    field.SetValue(to, fieldFrom.GetValue(from));

            }

            return to;

        }

    }
}
