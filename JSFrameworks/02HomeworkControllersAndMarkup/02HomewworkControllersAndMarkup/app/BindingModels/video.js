var Video = function(){
    function Video(title,picture,length,category, subscriberCount,date,hasSubtitles){
        this.title = title;
        this.picture = picture;
        this.length = length;
        this.category = category;
        this.subscriberCount = subscriberCount;
        this.date = date.toLocaleDateString();
        this.hasSubtitles = hasSubtitles;
        this._comments = [];
    }

    Video.prototype.addComment = function(comment){
        this._comments.push(comment);
    };

    return Video;
}();
