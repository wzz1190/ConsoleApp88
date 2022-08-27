// http://tool.sufeinet.com/

using System;
using System.Collections.Generic;

namespace SufeiNet
{

    public class Avatar168x168
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class Avatar300x300
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class AvatarLarger
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class AvatarMedium
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class AvatarThumb
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class AwemeControl
    {
        public bool can_comment { get; set; }
        public bool can_forward { get; set; }
        public bool can_share { get; set; }
        public bool can_show_comment { get; set; }
    }

    public class CoverUrl
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class SearchImpr
    {
        public string entity_id { get; set; }
    }

    public class ShareQrcodeUrl
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class ShareInfo
    {
        public string share_desc { get; set; }
        public string share_desc_info { get; set; }
        public ShareQrcodeUrl share_qrcode_url { get; set; }
        public string share_title { get; set; }
        public string share_title_myself { get; set; }
        public string share_title_other { get; set; }
        public string share_url { get; set; }
        public string share_weibo_desc { get; set; }
    }

    public class VideoIcon
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<object> url_list { get; set; }
        public int width { get; set; }
    }


    public class AwemeControl2
    {
        public bool can_comment { get; set; }
        public bool can_forward { get; set; }
        public bool can_share { get; set; }
        public bool can_show_comment { get; set; }
    }

    public class Author2
    {
        public object ad_cover_url { get; set; }
        public object ban_user_functions { get; set; }
        public object can_set_geofencing { get; set; }
        public object card_entries { get; set; }
        public object card_entries_not_display { get; set; }
        public object card_sort_priority { get; set; }
        public object cf_list { get; set; }
        public object cha_list { get; set; }
        public object cover_url { get; set; }
        public object display_info { get; set; }
        public object followers_detail { get; set; }
        public object geofencing { get; set; }
        public object homepage_bottom_toast { get; set; }
        public object im_role_ids { get; set; }
        public object interest_tags { get; set; }
        public object item_list { get; set; }
        public object link_item_list { get; set; }
        public object need_points { get; set; }
        public object new_story_cover { get; set; }
        public object offline_info_list { get; set; }
        public object personal_tag_list { get; set; }
        public object platform_sync_info { get; set; }
        public object relative_users { get; set; }
        public object signature_extra { get; set; }
        public object type_label { get; set; }
        public object user_permissions { get; set; }
        public object user_tags { get; set; }
        public object white_cover_url { get; set; }
    }

    public class ExtraAttr
    {
        public bool is_live { get; set; }
    }

    public class SearchImpr2
    {
        public string entity_id { get; set; }
    }

    public class ShareInfo2
    {
        public int bool_persist { get; set; }
        public string share_desc { get; set; }
        public string share_desc_info { get; set; }
        public string share_quote { get; set; }
        public string share_signature_desc { get; set; }
        public string share_signature_url { get; set; }
        public string share_title { get; set; }
        public string share_title_myself { get; set; }
        public string share_title_other { get; set; }
        public string share_url { get; set; }
        public string share_weibo_desc { get; set; }
    }

    public class ChaList
    {
        public Author2 author { get; set; }
        public object banner_list { get; set; }
        public object cha_attrs { get; set; }
        public string cha_name { get; set; }
        public string cid { get; set; }
        public int collect_stat { get; set; }
        public IList<object> connect_music { get; set; }
        public string desc { get; set; }
        public ExtraAttr extra_attr { get; set; }
        public string hashtag_profile { get; set; }
        public int is_challenge { get; set; }
        public bool is_commerce { get; set; }
        public bool is_pgcshow { get; set; }
        public string schema { get; set; }
        public SearchImpr2 search_impr { get; set; }
        public ShareInfo2 share_info { get; set; }
        public object show_items { get; set; }
        public int sub_type { get; set; }
        public int type { get; set; }
        public int user_count { get; set; }
        public int view_count { get; set; }
    }

    public class CommerceInfo
    {
    }

    public class Descendants
    {
        public string notify_msg { get; set; }
        public IList<string> platforms { get; set; }
    }

    public class HotList
    {
        public string extra { get; set; }
        public string footer { get; set; }
        public string group_id { get; set; }
        public string header { get; set; }
        public int hot_score { get; set; }
        public string i18n_title { get; set; }
        public string image_url { get; set; }
        public int pattern_type { get; set; }
        public int rank { get; set; }
        public string schema { get; set; }
        public string sentence { get; set; }
        public int sentence_id { get; set; }
        public string title { get; set; }
        public int type { get; set; }
        public int view_count { get; set; }
    }

    public class HotsearchInfo
    {
        public string ailab_extra { get; set; }
        public string log_extra { get; set; }
        public string biz_extra { get; set; }
    }

    public class ImpressionData
    {
        public IList<object> group_id_list_a { get; set; }
        public IList<object> group_id_list_b { get; set; }
        public IList<object> similar_id_list_a { get; set; }
        public IList<object> similar_id_list_b { get; set; }
    }

    public class AvatarLarge
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class AvatarMedium2
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class AvatarThumb2
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class CoverHd
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class CoverLarge
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class CoverMedium
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class CoverThumb
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class LunaInfo
    {
        public bool is_luna_user { get; set; }
        public bool? has_copyright { get; set; }
    }

    public class PlayUrl
    {
        public int height { get; set; }
        public string uri { get; set; }
        public string url_key { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class SearchImpr3
    {
        public string entity_id { get; set; }
    }

    public class StrongBeatUrl
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class CoverColorHsv
    {
        public int h { get; set; }
        public int s { get; set; }
        public int v { get; set; }
    }

    public class Chorus
    {
        public int duration_ms { get; set; }
        public int start_ms { get; set; }
    }

    public class Song
    {
        public object artists { get; set; }
        public Chorus chorus { get; set; }
        public long id { get; set; }
        public string id_str { get; set; }
        public string title { get; set; }
    }


    public class PoiBiz
    {
    }

    public class PoiPatchInfo
    {
        public string extra { get; set; }
        public int item_patch_poi_prompt_mark { get; set; }
    }

    public class RiskInfos
    {
        public string content { get; set; }
        public bool risk_sink { get; set; }
        public int type { get; set; }
        public bool vote { get; set; }
        public bool warn { get; set; }
    }

    public class ShareInfo3
    {
        public int bool_persist { get; set; }
        public string share_desc { get; set; }
        public string share_desc_info { get; set; }
        public string share_link_desc { get; set; }
        public string share_quote { get; set; }
        public string share_signature_desc { get; set; }
        public string share_signature_url { get; set; }
        public string share_title { get; set; }
        public string share_title_myself { get; set; }
        public string share_title_other { get; set; }
        public string share_url { get; set; }
        public string share_weibo_desc { get; set; }
    }

    public class Statistics
    {
        public string aweme_id { get; set; }
        public int collect_count { get; set; }
        public int comment_count { get; set; }
        public string digest { get; set; }
        public int digg_count { get; set; }
        public int download_count { get; set; }
        public int exposure_count { get; set; }
        public int forward_count { get; set; }
        public int live_watch_count { get; set; }
        public int lose_comment_count { get; set; }
        public int lose_count { get; set; }
        public int play_count { get; set; }
        public int share_count { get; set; }
        public int whatsapp_share_count { get; set; }
    }

    public class AwemeEditInfo
    {
        public int button_status { get; set; }
        public string button_toast { get; set; }
    }

    public class ReviewResult
    {
        public string extra { get; set; }
        public int review_status { get; set; }
    }

    public class Status
    {
        public bool allow_comment { get; set; }
        public bool allow_share { get; set; }
        public AwemeEditInfo aweme_edit_info { get; set; }
        public string aweme_id { get; set; }
        public int dont_share_status { get; set; }
        public int download_status { get; set; }
        public bool in_reviewing { get; set; }
        public bool is_delete { get; set; }
        public bool is_private { get; set; }
        public bool is_prohibited { get; set; }
        public int part_see { get; set; }
        public int private_status { get; set; }
        public ReviewResult review_result { get; set; }
        public int reviewed { get; set; }
        public bool self_see { get; set; }
        public int video_hide_search { get; set; }
        public bool with_fusion_goods { get; set; }
        public bool with_goods { get; set; }
    }

    public class TextExtra
    {
        public int end { get; set; }
        public string hashtag_id { get; set; }
        public string hashtag_name { get; set; }
        public bool is_commerce { get; set; }
        public int start { get; set; }
        public int type { get; set; }
        public string sec_uid { get; set; }
        public string user_id { get; set; }
    }

    public class PlayAddr
    {
        public int data_size { get; set; }
        public string file_cs { get; set; }
        public string file_hash { get; set; }
        public int height { get; set; }
        public string uri { get; set; }
        public string url_key { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class BitRate
    {
        public int fps { get; set; }
        public string hdr_bit { get; set; }
        public string hdr_type { get; set; }
        public int bit_rate { get; set; }
        public string gear_name { get; set; }
        public int is_bytevc1 { get; set; }
        public int is_h265 { get; set; }
        public PlayAddr play_addr { get; set; }
        public int quality_type { get; set; }
    }

    public class Cover
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class DownloadAddr
    {
        public int data_size { get; set; }
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class DynamicCover
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class OptimizedCover
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class OriginCover
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class PlayAddr2
    {
        public int data_size { get; set; }
        public string file_cs { get; set; }
        public string file_hash { get; set; }
        public int height { get; set; }
        public string uri { get; set; }
        public string url_key { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class PlayAddrLowbr
    {
        public int data_size { get; set; }
        public string file_cs { get; set; }
        public string file_hash { get; set; }
        public int height { get; set; }
        public string uri { get; set; }
        public string url_key { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class Video
    {
        public object big_thumbs { get; set; }
        public IList<BitRate> bit_rate { get; set; }
        public int cdn_url_expired { get; set; }
        public Cover cover { get; set; }
        public DownloadAddr download_addr { get; set; }
        public int duration { get; set; }
        public DynamicCover dynamic_cover { get; set; }
        public bool has_watermark { get; set; }
        public int height { get; set; }
        public int is_bytevc1 { get; set; }
        public bool is_callback { get; set; }
        public int is_h265 { get; set; }
        public int is_long_video { get; set; }
        public int is_source_hdr { get; set; }
        public string meta { get; set; }
        public string misc_download_addrs { get; set; }
        public bool need_set_token { get; set; }
        public OptimizedCover optimized_cover { get; set; }
        public OriginCover origin_cover { get; set; }
        public PlayAddr2 play_addr { get; set; }
        public PlayAddrLowbr play_addr_lowbr { get; set; }
        public string ratio { get; set; }
        public object tags { get; set; }
        public bool use_static_cover { get; set; }
        public string video_model { get; set; }
        public int width { get; set; }
    }

    public class VideoControl
    {
        public bool allow_douplus { get; set; }
        public bool allow_download { get; set; }
        public bool allow_duet { get; set; }
        public bool allow_dynamic_wallpaper { get; set; }
        public bool allow_music { get; set; }
        public bool allow_react { get; set; }
        public bool allow_share { get; set; }
        public bool allow_stitch { get; set; }
        public bool download_ignore_visibility { get; set; }
        public int draft_progress_bar { get; set; }
        public bool duet_ignore_visibility { get; set; }
        public int prevent_download_type { get; set; }
        public bool share_grayed { get; set; }
        public bool share_ignore_visibility { get; set; }
        public int share_type { get; set; }
        public int show_progress_bar { get; set; }
        public int timer_status { get; set; }
    }

    public class XiguaTask
    {
        public bool is_xigua_task { get; set; }
    }

    public class CoverUrl2
    {
        public int height { get; set; }
        public string uri { get; set; }
        public IList<string> url_list { get; set; }
        public int width { get; set; }
    }

    public class ShareInfo4
    {
        public string share_desc { get; set; }
        public string share_desc_info { get; set; }
        public string share_title { get; set; }
        public string share_title_myself { get; set; }
        public string share_title_other { get; set; }
        public string share_url { get; set; }
        public string share_weibo_desc { get; set; }
    }

    public class Statis
    {
        public int collect_vv { get; set; }
        public int current_episode { get; set; }
        public int play_vv { get; set; }
        public int updated_to_episode { get; set; }
    }

    public class Status2
    {
        public int is_collected { get; set; }
        public int status { get; set; }
    }

    public class MixInfo
    {
        public CoverUrl2 cover_url { get; set; }
        public int create_time { get; set; }
        public string desc { get; set; }
        public string extra { get; set; }
        public object ids { get; set; }
        public int is_serial_mix { get; set; }
        public string mix_id { get; set; }
        public string mix_name { get; set; }
        public int mix_pic_type { get; set; }
        public int mix_type { get; set; }
        public ShareInfo4 share_info { get; set; }
        public Statis statis { get; set; }
        public Status2 status { get; set; }
        public int update_time { get; set; }
        public string watched_item { get; set; }
    }

    public class RelationLabel
    {
        public string label_info { get; set; }
        public int show_type { get; set; }
        public int type { get; set; }
    }

    public class AwemeList
    {
      //  public Author author { get; set; }
        public object author_user_id { get; set; }
        public AwemeControl2 aweme_control { get; set; }
        public string aweme_id { get; set; }
        public int aweme_type { get; set; }
        public int bodydance_score { get; set; }
        public IList<ChaList> cha_list { get; set; }
        public string city { get; set; }
        public bool cmt_swt { get; set; }
        public int collect_stat { get; set; }
        public CommerceInfo commerce_info { get; set; }
        public int create_time { get; set; }
        public string desc { get; set; }
        public string desc_language { get; set; }
        public Descendants descendants { get; set; }
        public string distance { get; set; }
        public int distribute_type { get; set; }
        public int duration { get; set; }
        public string group_id { get; set; }
        public int guide_btn_type { get; set; }
        public bool has_vs_entry { get; set; }
        public bool have_dashboard { get; set; }
        public HotList hot_list { get; set; }
        public HotsearchInfo hotsearch_info { get; set; }
        public ImpressionData impression_data { get; set; }
        public bool is_fantasy { get; set; }
        public bool is_first_video { get; set; }
        public int is_hash_tag { get; set; }
        public bool is_in_scope { get; set; }
        public bool is_karaoke { get; set; }
        public bool is_pgcshow { get; set; }
        public int is_preview { get; set; }
        public bool is_relieve { get; set; }
        public int is_story { get; set; }
        public int is_top { get; set; }
        public bool is_vr { get; set; }
        public int item_comment_settings { get; set; }
        public int item_duet { get; set; }
        public int item_react { get; set; }
        public int item_share { get; set; }
        public int item_stitch { get; set; }
        public string misc_info { get; set; }
        public int nearby_level { get; set; }
        public bool need_vs_entry { get; set; }
        public PoiBiz poi_biz { get; set; }
        public PoiPatchInfo poi_patch_info { get; set; }
        public bool prevent_download { get; set; }
        public int rate { get; set; }
        public string region { get; set; }
        public bool report_action { get; set; }
        public RiskInfos risk_infos { get; set; }
        public ShareInfo3 share_info { get; set; }
        public string share_url { get; set; }
        public string sort_label { get; set; }
        public Statistics statistics { get; set; }
        public Status status { get; set; }
        public int story_ttl { get; set; }
        public IList<TextExtra> text_extra { get; set; }
        public int user_digged { get; set; }
        public Video video { get; set; }
        public VideoControl video_control { get; set; }
        public int vr_type { get; set; }
        public bool with_promotional_music { get; set; }
        public bool without_watermark { get; set; }
        public XiguaTask xigua_task { get; set; }
        public MixInfo mix_info { get; set; }
        public RelationLabel relation_label { get; set; }
    }

    public class Extra
    {
        public IList<object> fatal_item_ids { get; set; }
        public string logid { get; set; }
        public long now { get; set; }
    }

    public class HotspotBottomBarInfo
    {
        public string schema { get; set; }
        public string title { get; set; }
    }

    public class LogPb
    {
        public string impr_id { get; set; }
    }

    public class SufeiNet_Test
    {
        public IList<AwemeList> aweme_list { get; set; }
        public IList<object> comment_list { get; set; }
        public int cursor { get; set; }
        public Extra extra { get; set; }
        public int has_more { get; set; }
        public string hidden_video_info { get; set; }
        public HotspotBottomBarInfo hotspot_bottom_bar_info { get; set; }
        public int hotspot_feed_bottom_bar_type { get; set; }
        public LogPb log_pb { get; set; }
        public IList<object> micro_article_list { get; set; }
        public int status_code { get; set; }
        public object status_msg { get; set; }
        public object word_info { get; set; }
    }

}
