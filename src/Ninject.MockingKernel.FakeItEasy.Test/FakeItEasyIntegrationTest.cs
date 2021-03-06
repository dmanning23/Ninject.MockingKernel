//-------------------------------------------------------------------------------
// <copyright file="FakeItEasyIntegrationTest.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2015 Ninject Project Contributors
//   Authors: Scott Xu (scott-xu@msn.com)
//           
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   you may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Ninject.MockingKernel.FakeItEasy
{
    using global::FakeItEasy;

    /// <summary>
    /// Tests the FakeItEasy mocking kernel.
    /// </summary>
    public class FakeItEasyIntegrationTest : IntegrationTest
    {
        /// <summary>
        /// Creates the kernel.
        /// </summary>
        /// <returns>The newly created kernel.</returns>
        protected override MockingKernel CreateKernel()
        {
            return new FakeItEasyMockingKernel();
        }

        /// <summary>
        /// Asserts that do was called.
        /// </summary>
        /// <param name="dummyService">The dummy service.</param>
        protected override void AssertDoWasCalled(IDummyService dummyService)
        {
            A.CallTo(() => dummyService.Do()).MustHaveHappened();
        }
    }
}
