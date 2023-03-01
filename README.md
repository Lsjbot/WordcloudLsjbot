# WordcloudLsjbot
Library for creating word clouds

Simple and versatile tool for creating word clouds. 

Minimal usage:

    WordCloudClass mycloud = new WordCloudClass(xsize,ysize); //create cloud maker
    foreach (string word in weightdict.Keys)     //add words, with weight for each word
        mycloud.Add(word,weightdict[word]);
    mycloud.Arrange();                           //arrange the words into a cloud
    var image = mycloud.Draw();                  //get the cloud as an image
