using Autofac.Core.Resolving.Middleware;
using Autofac.Core.Resolving.Pipeline;
using Moq;
using Xunit;

namespace Autofac.Test.Core.Resolving
{
    public class CircularDependencyMiddlewareTests
    {
        [Fact]
        public void NextCalled_OperationIsNotIDependencyTrackingResolveOperation_MiddlewareSkipped()
        {
            var resolveRequestContextMock = new Mock<ResolveRequestContextBase>();
            var middleware =
                new CircularDependencyDetectorMiddleware(CircularDependencyDetectorMiddleware.DefaultMaxResolveDepth);

            middleware.Execute(resolveRequestContextMock.Object, context => { });

            resolveRequestContextMock.Verify(context => context.Operation.RequestDepth, Times.Never);
        }
    }
}
