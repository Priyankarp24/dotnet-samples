// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using DriveV3Snippets;
using NUnit.Framework;

namespace DriveV3SnippetsTest
{
    // Unit testcase for drive v3 touch file snippet
    [TestFixture]
    public class TouchFileTest : BaseTest
    {
        //TODO(developer) - Provide absolute path of the file
        private string filePath = "files/photo.jpg";
        
        [Test]
        public void TestTouchFile()
        {
            var id = CreateTestBlob(filePath);
            var now = DateTime.Now;
            var modifiedTime = TouchFile.DriveTouchFile(id, now);
            Assert.AreEqual(now.ToString(), modifiedTime.Value.ToString());
        }
    }
}