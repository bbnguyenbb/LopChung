


using OOPInterface;

ManyFile manyf = new();
manyf.WriteTextFile();
manyf.WriteBinaryFile();
manyf.ReadFile();
((ITextFile)manyf).ReadFile();
((IBinaryFile)manyf).ReadFile();
//(manyf as IBinaryFile).ReadFile();


SomeFile somef = new();
somef.WriteTextFile();
somef.WriteBinaryFile();
((ITextFile)somef).ReadFile();
((IBinaryFile)somef).ReadFile();
((IBinaryFile)somef).ShowInfo();
//(somef as IBinaryFile).ReadFile();

IBinaryFile binaryFile = new SomeFile();
binaryFile.WriteBinaryFile();
binaryFile.ReadFile();
binaryFile.ShowInfo();
((SomeFile)binaryFile).SearchFile();

binaryFile = new ManyFile();
binaryFile.WriteBinaryFile();
binaryFile.ShowInfo();
binaryFile.ReadFile();

((ITextFile)binaryFile).WriteTextFile();
((ITextFile)binaryFile).ReadFile();
