# WordcloudLsjbot
Library for creating word clouds

Simple and versatile tool for creating word clouds. Uses SkiaSharp for graphics.

**Minimal usage:**

    WordCloudClass mycloud = new WordCloudClass(xsize,ysize); //create cloud maker
    foreach (string word in weightdict.Keys)     //add words, with weight for each word
        mycloud.Add(word,weightdict[word]);
    mycloud.Arrange();                           //arrange the words into a cloud
    var image = mycloud.Draw();                  //get the cloud as an image

**Cloud options (to be called between constructor and Arrange):**

SetShape(string shape): Shape of cloud. Valid values: "circle", "ellipse", "rectangle". Defaults to rectangle.

SetFontSize(int mnfont, int mxfont): Smallest and largest font size for words in cloud. Defaults: 12 and 64.

SetBackgroundColor(SKColor skc): Set the background color to skc. Default: pale pink.

SetColorRange(float minhue, float maxhue, float minsat, float maxsat, float minval, float maxval): Each word is given a random color within the range of hue, saturation and brightness specified here. Default: minhue = 0, maxhue = 250; minsat = 0, maxsat = 99; minval = 0, maxval = 99. The defaults are also the largest allowed ranges. 

SetSpecificWordColor(SKColor skc): Draw all words with the color skc. Overrides SetColorRange. Call with skc=null to revert to random word colors.

SetSpecial(bool skipcentral, bool titspecial): If skipcentral is true, an empty square is left in the middle of the cloud, to leave space for e.g. an image. If titspecial is true, the first three words get special treatment. Can be used e.g. to put title and author integrated in the cloud.

SetSpecialColors(SKColor w1c, SKColor, w2c): If titspecial is true, color w1c is used for word 1 and 3, and color w2c is used for word 2.

**Output**

SKBitmap Draw(string title). Returns the cloud as a bitmap, with the string "title" in the upper corner.
SKData DrawData(string title). Returns the cloud as data (png encoded), for further processing.
