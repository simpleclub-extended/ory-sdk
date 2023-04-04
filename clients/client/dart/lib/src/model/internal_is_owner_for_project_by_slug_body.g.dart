// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'internal_is_owner_for_project_by_slug_body.dart';

// **************************************************************************
// BuiltValueGenerator
// **************************************************************************

class _$InternalIsOwnerForProjectBySlugBody
    extends InternalIsOwnerForProjectBySlugBody {
  @override
  final String? projectScope;
  @override
  final String projectSlug;
  @override
  final String subject;

  factory _$InternalIsOwnerForProjectBySlugBody(
          [void Function(InternalIsOwnerForProjectBySlugBodyBuilder)?
              updates]) =>
      (new InternalIsOwnerForProjectBySlugBodyBuilder()..update(updates))
          ._build();

  _$InternalIsOwnerForProjectBySlugBody._(
      {this.projectScope, required this.projectSlug, required this.subject})
      : super._() {
    BuiltValueNullFieldError.checkNotNull(
        projectSlug, r'InternalIsOwnerForProjectBySlugBody', 'projectSlug');
    BuiltValueNullFieldError.checkNotNull(
        subject, r'InternalIsOwnerForProjectBySlugBody', 'subject');
  }

  @override
  InternalIsOwnerForProjectBySlugBody rebuild(
          void Function(InternalIsOwnerForProjectBySlugBodyBuilder) updates) =>
      (toBuilder()..update(updates)).build();

  @override
  InternalIsOwnerForProjectBySlugBodyBuilder toBuilder() =>
      new InternalIsOwnerForProjectBySlugBodyBuilder()..replace(this);

  @override
  bool operator ==(Object other) {
    if (identical(other, this)) return true;
    return other is InternalIsOwnerForProjectBySlugBody &&
        projectScope == other.projectScope &&
        projectSlug == other.projectSlug &&
        subject == other.subject;
  }

  @override
  int get hashCode {
    var _$hash = 0;
    _$hash = $jc(_$hash, projectScope.hashCode);
    _$hash = $jc(_$hash, projectSlug.hashCode);
    _$hash = $jc(_$hash, subject.hashCode);
    _$hash = $jf(_$hash);
    return _$hash;
  }

  @override
  String toString() {
    return (newBuiltValueToStringHelper(r'InternalIsOwnerForProjectBySlugBody')
          ..add('projectScope', projectScope)
          ..add('projectSlug', projectSlug)
          ..add('subject', subject))
        .toString();
  }
}

class InternalIsOwnerForProjectBySlugBodyBuilder
    implements
        Builder<InternalIsOwnerForProjectBySlugBody,
            InternalIsOwnerForProjectBySlugBodyBuilder> {
  _$InternalIsOwnerForProjectBySlugBody? _$v;

  String? _projectScope;
  String? get projectScope => _$this._projectScope;
  set projectScope(String? projectScope) => _$this._projectScope = projectScope;

  String? _projectSlug;
  String? get projectSlug => _$this._projectSlug;
  set projectSlug(String? projectSlug) => _$this._projectSlug = projectSlug;

  String? _subject;
  String? get subject => _$this._subject;
  set subject(String? subject) => _$this._subject = subject;

  InternalIsOwnerForProjectBySlugBodyBuilder() {
    InternalIsOwnerForProjectBySlugBody._defaults(this);
  }

  InternalIsOwnerForProjectBySlugBodyBuilder get _$this {
    final $v = _$v;
    if ($v != null) {
      _projectScope = $v.projectScope;
      _projectSlug = $v.projectSlug;
      _subject = $v.subject;
      _$v = null;
    }
    return this;
  }

  @override
  void replace(InternalIsOwnerForProjectBySlugBody other) {
    ArgumentError.checkNotNull(other, 'other');
    _$v = other as _$InternalIsOwnerForProjectBySlugBody;
  }

  @override
  void update(
      void Function(InternalIsOwnerForProjectBySlugBodyBuilder)? updates) {
    if (updates != null) updates(this);
  }

  @override
  InternalIsOwnerForProjectBySlugBody build() => _build();

  _$InternalIsOwnerForProjectBySlugBody _build() {
    final _$result = _$v ??
        new _$InternalIsOwnerForProjectBySlugBody._(
            projectScope: projectScope,
            projectSlug: BuiltValueNullFieldError.checkNotNull(projectSlug,
                r'InternalIsOwnerForProjectBySlugBody', 'projectSlug'),
            subject: BuiltValueNullFieldError.checkNotNull(
                subject, r'InternalIsOwnerForProjectBySlugBody', 'subject'));
    replace(_$result);
    return _$result;
  }
}

// ignore_for_file: deprecated_member_use_from_same_package,type=lint
