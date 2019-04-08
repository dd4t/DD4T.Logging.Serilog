using System;
using System.Collections.Generic;
using DD4T.ContentModel.Contracts.Logging;
using DD4T.Core.Contracts.DependencyInjection;

namespace DD4T.Logging.SerilogSeq
{
    public class DependencyMappings : IDependencyMapper
    {
        private IDictionary<Type, Type> GetSingleInstanceMappings()
        {
            var mappings = new Dictionary<Type, Type>
            {
                { typeof(ILogger), typeof(DefaultLogger) }
            };

            return mappings;
        }

        public IDictionary<Type, Type> SingleInstanceMappings => GetSingleInstanceMappings();

        public IDictionary<Type, Type> PerHttpRequestMappings => null;

        public IDictionary<Type, Type> PerLifeTimeMappings => null;

        public IDictionary<Type, Type> PerDependencyMappings => null;
    }
}
