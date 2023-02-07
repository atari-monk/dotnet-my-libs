using Net.Examples;

var questions = new IReply[]{
    new Question1Reply(),
    new Question2Reply(),
    new Question3Reply(),
    new Question4Reply()
};
foreach (var question in questions)
{
    question.GetReply();
}