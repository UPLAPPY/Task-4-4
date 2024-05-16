namespace Task_4_4._2.ViewModels;

using Task_4_4._2.Models;
using System.Collections.Generic;
using System;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        BlogEntities =
        [
            new BlogEntity {Article = "Заголовок 1", Text = "text 1", TagsList = ["Tag11", "Tag12", "Tag13", "Tag14"], ImagePath="frfz.png"},
            new BlogEntity {Article = "Заголовок 2", Text = "text 2", TagsList = ["Tag21", "Tag22", "Tag23", "Tag24"], ImagePath="frfz.png"},
            new BlogEntity {Article = "Заголовок 3", Text = "text 3", TagsList = ["Tag31", "Tag32", "Tag33", "Tag34"], ImagePath="frfz.png"}
        ];
        NewsEntities =
        [
            new NewsEntity { Text1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam egestas ut leo non euismod. Aliquam dui est, mattis eget nulla ac, rutrum porta nibh. Proin ultricies sollicitudin enim rutrum ornare. Mauris risus arcu, consectetur sit amet sem quis.",
                             Text2 = "Donec sodales ligula sed gravida maximus. Integer tincidunt purus eu libero auctor, vitae dapibus risus condimentum. Proin laoreet euismod nisl, id rhoncus elit ultricies hendrerit.",
                             PublishDate = DateTime.Now},
            new NewsEntity { Text1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam egestas ut leo non euismod. Aliquam dui est, mattis eget nulla ac, rutrum porta nibh. Proin ultricies sollicitudin enim rutrum ornare. Mauris risus arcu, consectetur sit amet sem quis.",
                             Text2 = "Donec sodales ligula sed gravida maximus. Integer tincidunt purus eu libero auctor, vitae dapibus risus condimentum. Proin laoreet euismod nisl, id rhoncus elit ultricies hendrerit.",
                             PublishDate = DateTime.Now},
            new NewsEntity { Text1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam egestas ut leo non euismod. Aliquam dui est, mattis eget nulla ac, rutrum porta nibh. Proin ultricies sollicitudin enim rutrum ornare. Mauris risus arcu, consectetur sit amet sem quis.",
                             Text2 = "Donec sodales ligula sed gravida maximus. Integer tincidunt purus eu libero auctor, vitae dapibus risus condimentum. Proin laoreet euismod nisl, id rhoncus elit ultricies hendrerit.",
                             PublishDate = DateTime.Now}
        ];
    }
    public List<BlogEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }

}